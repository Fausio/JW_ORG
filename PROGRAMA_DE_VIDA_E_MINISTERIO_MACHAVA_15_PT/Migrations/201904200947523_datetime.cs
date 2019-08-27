namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_Designacao", "Tempo", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_Designacao", "Tempo");
        }
    }
}
