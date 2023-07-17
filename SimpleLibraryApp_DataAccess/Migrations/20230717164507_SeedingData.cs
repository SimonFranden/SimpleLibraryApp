using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleLibraryApp_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Title" },
                values: new object[,]
                {
                    { 1, "Paulo Coelho", "The Alchemist" },
                    { 2, "J.K. Rowling", "Harry Potter and the Sorcerer's Stone" },
                    { 3, "J.R.R. Tolkien", "The Lord of the Rings: The Fellowship of the Ring" },
                    { 4, "Harper Lee", "To Kill a Mockingbird" },
                    { 5, "F. Scott Fitzgerald", "The Great Gatsby" },
                    { 6, "Jane Austen", "Pride and Prejudice" },
                    { 7, "George Orwell", "1984" },
                    { 8, "J.D. Salinger", "The Catcher in the Rye" },
                    { 9, "C.S. Lewis", "The Chronicles of Narnia: The Lion, the Witch, and the Wardrobe" },
                    { 10, "Herman Melville", "Moby-Dick" },
                    { 11, "Virginia Woolf", "To the Lighthouse" },
                    { 12, "Douglas Adams", "The Hitchhiker's Guide to the Galaxy" },
                    { 13, "Oscar Wilde", "The Picture of Dorian Gray" },
                    { 14, "Aldous Huxley", "Brave New World" },
                    { 15, "Charlotte Brontë", "Jane Eyre" },
                    { 16, "J.R.R. Tolkien", "The Hobbit" },
                    { 17, "Alexandre Dumas", "The Count of Monte Cristo" },
                    { 18, "Gabriel García Márquez", "One Hundred Years of Solitude" },
                    { 19, "Fyodor Dostoevsky", "Crime and Punishment" },
                    { 20, "Antoine de Saint-Exupéry", "The Little Prince" },
                    { 21, "Emily Brontë", "Wuthering Heights" },
                    { 22, "Stephen King", "The Shining" },
                    { 23, "Margaret Atwood", "The Handmaid's Tale" },
                    { 24, "Oscar Wilde", "The Picture of Dorian Gray" },
                    { 25, "Joseph Heller", "The Catch-22" },
                    { 26, "Dan Brown", "The Da Vinci Code" },
                    { 27, "Margaret Mitchell", "Gone with the Wind" },
                    { 28, "John Steinbeck", "The Grapes of Wrath" },
                    { 29, "Mary Shelley", "Frankenstein" },
                    { 30, "Khaled Hosseini", "The Kite Runner" }
                });

            migrationBuilder.InsertData(
                table: "LentBooks",
                columns: new[] { "Id", "BookId", "CustomerId", "DateLent", "IsReturned" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 2, 2, 2, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 3, 3, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 4, 4, 4, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 5, 5, 5, new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 6, 3, 2, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 7, 1, 4, new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 8, 4, 3, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "LentBooks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LentBooks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LentBooks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LentBooks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LentBooks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LentBooks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LentBooks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LentBooks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
