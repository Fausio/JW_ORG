namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaRelacional : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TB_Pessoa", "DesignacaoID", "dbo.TB_Designacao");
            DropIndex("dbo.TB_Pessoa", new[] { "DesignacaoID" });
            CreateTable(
                "dbo.TB_DesignacaoPessoa",
                c => new
                    {
                        DesignacaoID = c.Int(nullable: false),
                        PessoaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DesignacaoID, t.PessoaID })
                .ForeignKey("dbo.TB_Designacao", t => t.DesignacaoID, cascadeDelete: true)
                .ForeignKey("dbo.TB_Pessoa", t => t.PessoaID, cascadeDelete: true)
                .Index(t => t.DesignacaoID)
                .Index(t => t.PessoaID);
            
            AddColumn("dbo.TB_Pessoa", "Designacao_DesignacaoID", c => c.Int());
            CreateIndex("dbo.TB_Pessoa", "Designacao_DesignacaoID");
            AddForeignKey("dbo.TB_Pessoa", "Designacao_DesignacaoID", "dbo.TB_Designacao", "DesignacaoID");
            DropColumn("dbo.TB_Designacao", "PessoaID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TB_Designacao", "PessoaID", c => c.Int());
            DropForeignKey("dbo.TB_Pessoa", "Designacao_DesignacaoID", "dbo.TB_Designacao");
            DropForeignKey("dbo.TB_DesignacaoPessoa", "PessoaID", "dbo.TB_Pessoa");
            DropForeignKey("dbo.TB_DesignacaoPessoa", "DesignacaoID", "dbo.TB_Designacao");
            DropIndex("dbo.TB_DesignacaoPessoa", new[] { "PessoaID" });
            DropIndex("dbo.TB_DesignacaoPessoa", new[] { "DesignacaoID" });
            DropIndex("dbo.TB_Pessoa", new[] { "Designacao_DesignacaoID" });
            DropColumn("dbo.TB_Pessoa", "Designacao_DesignacaoID");
            DropTable("dbo.TB_DesignacaoPessoa");
            CreateIndex("dbo.TB_Pessoa", "DesignacaoID");
            AddForeignKey("dbo.TB_Pessoa", "DesignacaoID", "dbo.TB_Designacao", "DesignacaoID");
        }
    }
}
