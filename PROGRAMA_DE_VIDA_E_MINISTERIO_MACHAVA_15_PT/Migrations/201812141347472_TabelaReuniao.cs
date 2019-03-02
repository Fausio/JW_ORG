namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaReuniao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reuniaos",
                c => new
                    {
                        ReuniaoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ReuniaoID);
            
            AddColumn("dbo.TB_Pessoa", "ReuniaoID", c => c.Int());
            CreateIndex("dbo.TB_Pessoa", "ReuniaoID");
            AddForeignKey("dbo.TB_Pessoa", "ReuniaoID", "dbo.Reuniaos", "ReuniaoID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_Pessoa", "ReuniaoID", "dbo.Reuniaos");
            DropIndex("dbo.TB_Pessoa", new[] { "ReuniaoID" });
            DropColumn("dbo.TB_Pessoa", "ReuniaoID");
            DropTable("dbo.Reuniaos");
        }
    }
}
