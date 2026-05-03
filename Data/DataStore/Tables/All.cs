using GoodsFlow.UserManager;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace GoodsFlow.Data.DataStore.Tables;

[Table("STORE")]
public class Store : BaseModel
{
    [PrimaryKey("store_id")]
    public int ID { get; set; }

    [Column("store_name")]
    public string? Name { get; set; }

    [Column("store_location")]
    public string? Location { get; set; }

    [Column("store_contact")]
    public string? Contact { get; set; }

    [Column("admin_name")]
    public string? AdminName { get; set; }

    [Column("admin_password")]
    public string? AdminPass { get; set; }

    [Column("store_salt")]
    public string? AdminSalt { get; set; }
}

[Table("USER")]
public class User : BaseModel
{
    [PrimaryKey("user_id")]
    public int ID { get; set; }

    [Column("user_name")]
    public string? Name { get; set; }

    [Column("user_password")]
    public string? Password { get; set; }

    [Column("user_salt")]
    public string? Salt { get; set; }

    [Column("store_id")]
    public int StoreID { get; set; }

    [Column("role_id")]
    public int RoleID { get; set; }
}

[Table("ROLE")]
public class Role : BaseModel
{
    [PrimaryKey("role_id")]
    public int ID { get; set; }

    [Column("admin_privileged")]
    public bool AdminPermission { get; set; }

    [Column("inventory_access")]
    public bool InventoryPermission { get; set; }

    [Column("checkout_access")]
    public bool CheckoutPermission { get; set; }

    [Column("product_management")]
    public bool ProductManagerPermission { get; set; }

    [Column("elevated_checkout_enabled")]
    public bool ElevatedCheckoutPermission { get; set; }

    [Column("store_id")]
    public int StoreID { get; set; }
}

[Table("SALES_REPORT")]
public class SalesReport
{
    [PrimaryKey("report_id")]
    public int ID { get; set; }

    [Column("report_date")]
    public DateTime Timestamp { get; set; }

    [Column("report_total")]
    public decimal Total { get; set; }

    [Column("store_id")]
    public int StoreID { get; set; }
}

[Table("RECEIPT")]
public class Receipt
{
    [PrimaryKey("receipt_id")]
    public int ID { get; set; }

    [Column("creation_datetime")]
    public DateTime Timestamp { get; set; }

    [Column("total")]
    public decimal Total { get; set; }

    [Column("store_id")]
    public int StoreID { get; set; }

    [Column("report_id")] 
    public int ReportID { get; set; }
}

[Table("TRANSACTION_PRODUCT")]
public class TransactionProduct
{
    [PrimaryKey("receipt_id")]
    public int ReceiptID { get; set; }

    [PrimaryKey("product_code")]
    public int ProductID { get; set; }

    [Column("quantity")]
    public float Quantity { get; set; }
}

[Table("PRODUCT")]
public class Product
{
    [PrimaryKey("product_code")]
    public int ID { get; set; }

    [Column("product_name")]
    public string? Name { get; set; }

    [Column("product_price")]
    public decimal Price { get; set; }

    [Column("product_inventory")]
    public int Inventory { get; set; }

    [Column("store_id")]
    public int StoreID { get; set; }

    [Column("provider_id")]
    public int ProviderID { get; set; }
}

[Table("PROVIDER")]
public class Provider
{
    [PrimaryKey("provider_id")]
    public int ID { get; set; }

    [Column("provider_name")]
    public string? Name { get; set; }

    [Column("provider_contact")]
    public string? Contact { get; set; }
}

[Table("PRODUCT_LOSS_REPORT")]
public class LossReport
{
    [PrimaryKey("preport_id")]
    public int ID { get; set; }

    [Column("preport_reason")]
    public string? Reason { get; set; }

    [Column("preport_datetime")]
    public DateTime Created { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("product_code")]
    public int ProductCode { get; set; }

    [Column("store_id")]
    public int StoreID { get; set; }

    [Column("user_id")]
    public int UserID { get; set; }

    [Column("clasif_id")]
    public int ClasifID { get; set; }
}

[Table("CLASIFICATIONS")]
public class Clasificaions
{
    [PrimaryKey("clasif_id")]
    public int ID { get; set; }

    [Column("clasif_name")]
    public string? Name { get; set; }
}