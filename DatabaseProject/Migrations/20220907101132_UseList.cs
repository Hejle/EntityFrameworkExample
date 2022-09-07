using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseProject.Migrations
{
    public partial class UseList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Payment_PaymentKey",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_PaymentKey",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "PaymentKey",
                table: "Transactions");

            migrationBuilder.AddColumn<int>(
                name: "TransactionKey",
                table: "Payment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_TransactionKey",
                table: "Payment",
                column: "TransactionKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Transactions_TransactionKey",
                table: "Payment",
                column: "TransactionKey",
                principalTable: "Transactions",
                principalColumn: "Key",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Transactions_TransactionKey",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_TransactionKey",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "TransactionKey",
                table: "Payment");

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentKey",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PaymentKey",
                table: "Transactions",
                column: "PaymentKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Payment_PaymentKey",
                table: "Transactions",
                column: "PaymentKey",
                principalTable: "Payment",
                principalColumn: "Key",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
