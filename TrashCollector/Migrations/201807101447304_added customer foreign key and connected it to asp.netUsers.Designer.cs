// <auto-generated />
namespace TrashCollector.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.2.0-61023")]
    public sealed partial class addedcustomerforeignkeyandconnectedittoaspnetUsers : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(addedcustomerforeignkeyandconnectedittoaspnetUsers));
        
        string IMigrationMetadata.Id
        {
            get { return "201807101447304_added customer foreign key and connected it to asp.netUsers"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}