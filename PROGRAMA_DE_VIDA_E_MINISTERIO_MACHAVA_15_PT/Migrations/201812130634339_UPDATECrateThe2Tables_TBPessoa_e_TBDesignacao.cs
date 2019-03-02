namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPDATECrateThe2Tables_TBPessoa_e_TBDesignacao : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TB_Designacao", "PessoaID", "dbo.TB_Pessoa");
            DropIndex("dbo.TB_Designacao", new[] { "PessoaID" });
            AddColumn("dbo.TB_Pessoa", "DesignacaoID", c => c.Int());
            CreateIndex("dbo.TB_Pessoa", "DesignacaoID");
            AddForeignKey("dbo.TB_Pessoa", "DesignacaoID", "dbo.TB_Designacao", "DesignacaoID");
            DropColumn("dbo.TB_Designacao", "PessoaID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TB_Designacao", "PessoaID", c => c.Int());
            DropForeignKey("dbo.TB_Pessoa", "DesignacaoID", "dbo.TB_Designacao");
            DropIndex("dbo.TB_Pessoa", new[] { "DesignacaoID" });
            DropColumn("dbo.TB_Pessoa", "DesignacaoID");
            CreateIndex("dbo.TB_Designacao", "PessoaID");
            AddForeignKey("dbo.TB_Designacao", "PessoaID", "dbo.TB_Pessoa", "PessoaID");
        }
    }
}
