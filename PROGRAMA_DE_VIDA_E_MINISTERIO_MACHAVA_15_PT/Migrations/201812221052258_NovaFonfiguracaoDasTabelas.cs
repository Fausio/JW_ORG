namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovaFonfiguracaoDasTabelas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TB_Pessoa", "Designacao_DesignacaoID", "dbo.TB_Designacao");
            DropForeignKey("dbo.TB_Pessoa", "Reuniao_CongregacaoID", "dbo.Congregacaos");
            DropForeignKey("dbo.TB_DesignacaoPessoa", "DesignacaoID", "dbo.TB_Designacao");
            DropForeignKey("dbo.TB_DesignacaoPessoa", "PessoaID", "dbo.TB_Pessoa");
            DropIndex("dbo.TB_Pessoa", new[] { "Designacao_DesignacaoID" });
            DropIndex("dbo.TB_Pessoa", new[] { "Reuniao_CongregacaoID" });
            DropIndex("dbo.TB_DesignacaoPessoa", new[] { "DesignacaoID" });
            DropIndex("dbo.TB_DesignacaoPessoa", new[] { "PessoaID" });
            AddColumn("dbo.TB_Designacao", "Descricao", c => c.String());
            DropColumn("dbo.TB_Designacao", "Nome");
            DropColumn("dbo.TB_Designacao", "Tempo");
            DropColumn("dbo.TB_Pessoa", "DesignacaoID");
            DropColumn("dbo.TB_Pessoa", "ReuniaoID");
            DropColumn("dbo.TB_Pessoa", "Designacao_DesignacaoID");
            DropColumn("dbo.TB_Pessoa", "Reuniao_CongregacaoID");
            DropTable("dbo.TB_DesignacaoPessoa");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TB_DesignacaoPessoa",
                c => new
                    {
                        DesignacaoID = c.Int(nullable: false),
                        PessoaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DesignacaoID, t.PessoaID });
            
            AddColumn("dbo.TB_Pessoa", "Reuniao_CongregacaoID", c => c.Int());
            AddColumn("dbo.TB_Pessoa", "Designacao_DesignacaoID", c => c.Int());
            AddColumn("dbo.TB_Pessoa", "ReuniaoID", c => c.Int());
            AddColumn("dbo.TB_Pessoa", "DesignacaoID", c => c.Int());
            AddColumn("dbo.TB_Designacao", "Tempo", c => c.String());
            AddColumn("dbo.TB_Designacao", "Nome", c => c.String());
            DropColumn("dbo.TB_Designacao", "Descricao");
            CreateIndex("dbo.TB_DesignacaoPessoa", "PessoaID");
            CreateIndex("dbo.TB_DesignacaoPessoa", "DesignacaoID");
            CreateIndex("dbo.TB_Pessoa", "Reuniao_CongregacaoID");
            CreateIndex("dbo.TB_Pessoa", "Designacao_DesignacaoID");
            AddForeignKey("dbo.TB_DesignacaoPessoa", "PessoaID", "dbo.TB_Pessoa", "PessoaID", cascadeDelete: true);
            AddForeignKey("dbo.TB_DesignacaoPessoa", "DesignacaoID", "dbo.TB_Designacao", "DesignacaoID", cascadeDelete: true);
            AddForeignKey("dbo.TB_Pessoa", "Reuniao_CongregacaoID", "dbo.Congregacaos", "CongregacaoID");
            AddForeignKey("dbo.TB_Pessoa", "Designacao_DesignacaoID", "dbo.TB_Designacao", "DesignacaoID");
        }
    }
}
