namespace WhatEatToday.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "name", c => c.String());
            AddColumn("dbo.AspNetUsers", "age", c => c.String());
            AddColumn("dbo.AspNetUsers", "token", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "token");
            DropColumn("dbo.AspNetUsers", "age");
            DropColumn("dbo.AspNetUsers", "name");
        }
    }
}
