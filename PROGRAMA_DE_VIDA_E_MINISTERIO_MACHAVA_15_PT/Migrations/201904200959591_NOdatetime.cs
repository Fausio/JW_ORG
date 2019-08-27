namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NOdatetime : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TB_Designacao", "Tempo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TB_Designacao", "Tempo", c => c.DateTime(nullable: false));
        }
    }
}
