using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Migrations
{

    [Migration(1)]
    public class _001_Users_And_Roles : Migration
    {
        public override void Down()
        {
            Delete.Table("role_users");
            Delete.Table("roles");
            Delete.Table("users");
        }

        public override void Up()
        {
            Create.Table("Users")
                .WithColumn("ID").AsInt32().Identity().PrimaryKey()
                .WithColumn("Username").AsString(128)
                .WithColumn("Mail").AsString(256)
                .WithColumn("Password_Hash").AsString(128);

            Create.Table("Roles")
                .WithColumn("ID").AsInt32().Identity().PrimaryKey()
                .WithColumn("RoleName").AsString(128);

            Create.Table("role_users")
                .WithColumn("UserID").AsInt32().ForeignKey("Users", "ID").OnDelete(System.Data.Rule.Cascade)
                .WithColumn("RoleID").AsInt32().ForeignKey("Roles", "ID").OnDelete(System.Data.Rule.Cascade);

        }
    }
}