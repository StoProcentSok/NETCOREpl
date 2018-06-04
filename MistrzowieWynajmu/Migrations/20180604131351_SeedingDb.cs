using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MistrzowieWynajmu.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Owners (Name,Surname,Phone) VALUES ('Michal', 'Buczek','123123123')");
            migrationBuilder.Sql("INSERT INTO Owners (Name,Surname,Phone) VALUES ('Adam', 'Nowak','999666999')");
            migrationBuilder.Sql("INSERT INTO Owners (Name,Surname,Phone) VALUES ('Ewa', 'Kowalska','777888777')");

            migrationBuilder.Sql("INSERT INTO Addresses (Street,City) VALUES ('Kopernika', 'Proszowice')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street,City) VALUES ('Kraków', 'Długa')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street,City) VALUES ('Wygwizdów', 'Cicha')");

            migrationBuilder.Sql("INSERT INTO Properties (Type, Description, Rooms, Area, Washer, Refrigerator, Iron, AddressId, OwnerId) VALUES ('0', 'Opis1', 7,170,1,1,1,1,1)");
            migrationBuilder.Sql("INSERT INTO Properties (Type, Description, Rooms, Area, Washer, Refrigerator, Iron, AddressId, OwnerId) VALUES ('0', 'Opis2', 5,120,1,0,1,2,2)");
            migrationBuilder.Sql("INSERT INTO Properties (Type, Description, Rooms, Area, Washer, Refrigerator, Iron, AddressId, OwnerId) VALUES ('1', 'Opis3', 2,70,1,1,0,3,3)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Owners");
            migrationBuilder.Sql("DELETE FROM Addresses");
            migrationBuilder.Sql("DELETE FROM Properties");

        }
    }
}
