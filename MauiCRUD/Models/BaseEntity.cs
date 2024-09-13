using SQLite;

namespace MauiCRUD.Models
{
    public abstract class BaseEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
     }
}