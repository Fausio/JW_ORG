namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Estado_e_Congregacao : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TB_Pessoa", "ReuniaoID", "dbo.Reuniaos");
            DropIndex("dbo.TB_Pessoa", new[] { "ReuniaoID" });
            CreateTable(
                "dbo.Congregacaos",
                c => new
                    {
                        CongregacaoID = c.Int(nullable: false, identity: true),
                        NomeCongregacao = c.String(),
                    })
                .PrimaryKey(t => t.CongregacaoID);
            
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        EstadoID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.EstadoID);
            
            AddColumn("dbo.TB_Pessoa", "Reuniao_CongregacaoID", c => c.Int());
            CreateIndex("dbo.TB_Pessoa", "Reuniao_CongregacaoID");
            AddForeignKey("dbo.TB_Pessoa", "Reuniao_CongregacaoID", "dbo.Congregacaos", "CongregacaoID");
            DropTable("dbo.Reuniaos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Reuniaos",
                c => new
                    {
                        ReuniaoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ReuniaoID);
            
            DropForeignKey("dbo.TB_Pessoa", "Reuniao_CongregacaoID", "dbo.Congregacaos");
            DropIndex("dbo.TB_Pessoa", new[] { "Reuniao_CongregacaoID" });
            DropColumn("dbo.TB_Pessoa", "Reuniao_CongregacaoID");
            DropTable("dbo.Estadoes");
            DropTable("dbo.Congregacaos");
            CreateIndex("dbo.TB_Pessoa", "ReuniaoID");
            AddForeignKey("dbo.TB_Pessoa", "ReuniaoID", "dbo.Reuniaos", "ReuniaoID");
        }
    }
}
