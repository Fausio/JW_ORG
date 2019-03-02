namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrateThe2Tables_TBPessoa_e_TBDesignacao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_Designacao",
                c => new
                    {
                        DesignacaoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        PessoaID = c.Int(),
                    })
                .PrimaryKey(t => t.DesignacaoID)
                .ForeignKey("dbo.TB_Pessoa", t => t.PessoaID)
                .Index(t => t.PessoaID);
            
            CreateTable(
                "dbo.TB_Pessoa",
                c => new
                    {
                        PessoaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.PessoaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_Designacao", "PessoaID", "dbo.TB_Pessoa");
            DropIndex("dbo.TB_Designacao", new[] { "PessoaID" });
            DropTable("dbo.TB_Pessoa");
            DropTable("dbo.TB_Designacao");
        }
    }
}
