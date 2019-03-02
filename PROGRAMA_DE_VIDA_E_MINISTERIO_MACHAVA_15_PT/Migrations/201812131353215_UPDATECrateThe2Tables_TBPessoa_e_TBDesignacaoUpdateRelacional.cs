namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPDATECrateThe2Tables_TBPessoa_e_TBDesignacaoUpdateRelacional : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_Designacao", "PessoaID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_Designacao", "PessoaID");
        }
    }
}
