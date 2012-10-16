using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFSP.ADS.SiPDV.Framework
{
    public class DatabaseConstants
    {
        #region -Constants-

        private const string PROJECT_NAME = "SiPDV.Database";

        #region -Operator-

        private const string OPERATOR_TABLE = "Tb_Operador";

        private const string OPERATOR_ID_COLUMN = "Id";
        private const string OPERATOR_CODE_COLUMN = "Codigo";
        private const string OPERATOR_NAME_COLUMN = "Nome";
        private const string OPERATOR_PASSWORD_COLUMN = "Senha";
        private const string OPERATOR_STATUS_COLUMN = "Status";

        private const string OPERATOR_ID_PARAM = "@Id";
        private const string OPERATOR_CODE_PARAM = "@Codigo";
        private const string OPERATOR_NAME_PARAM = "@Nome";
        private const string OPERATOR_PASSWORD_PARAM = "@Senha";
        private const string OPERATOR_STATUS_PARAM = "@Status";

        private const string OPERATOR_LOGIN_SQL = "SELECT Id FROM Tb_Operador WHERE Codigo = @Codigo AND Senha = @Senha";
        private const string OPERATOR_INSERT_SQL = "INSERT INTO Tb_Operador (Codigo, Nome, Senha, Status) VALUES (@Codigo, @Nome, @Senha, @Status)";
        private const string OPERATOR_UPDATE_SQL = "UPDATE Tb_Operador SET Codigo = @Codigo, Nome = @Nome, Senha = @Senha WHERE Id = @Id";
        private const string OPERATOR_UPDATE_STATUS_SQL = "UPDATE Tb_Operador SET Status = @Status WHERE Codigo = @Codigo";
        private const string OPERATOR_GET_ALL_SQL = "SELECT Id, Codigo, Nome FROM Tb_Operador WHERE Status = 1";
        private const string OPERATOR_GET_BY_ID_SQL = "SELECT Id, Codigo, Nome FROM Tb_Operador WHERE Id = @Id AND Status = 1";
        private const string OPERATOR_GET_BY_CODE_SQL = "SELECT Id, Codigo, Nome FROM Tb_Operador WHERE Codigo = @Codigo AND Status = 1";
        private const string OPERATOR_GET_BY_NAME_SQL = "SELECT Id, Codigo, Nome FROM Tb_Operador WHERE Nome LIKE @Nome AND Status = 1";

        #endregion

        #region -Product-

        private const string PRODUCT_TABLE = "Tb_Produto";

        private const string PRODUCT_ID_COLUMN = "Id";
        private const string PRODUCT_BAR_CODE_COLUMN = "Codigo_Barra";
        private const string PRODUCT_NAME_COLUMN = "Nome";
        private const string PRODUCT_DESCRIPTION_COLUMN = "Descricao";
        private const string PRODUCT_MEASUREMENT_UNIT_COLUMN = "Unidade_Medida";
        private const string PRODUCT_QUANTITY_COLUMN = "Quantidade_Estoque";
        private const string PRODUCT_STATUS_COLUMN = "Status";

        private const string PRODUCT_ID_PARAM = "@Id";
        private const string PRODUCT_BAR_CODE_PARAM = "@Codigo_Barra";
        private const string PRODUCT_NAME_PARAM = "@Nome";
        private const string PRODUCT_DESCRIPTION_PARAM = "@Descricao";
        private const string PRODUCT_MEASUREMENT_UNIT_PARAM = "@Unidade_Medida";
        private const string PRODUCT_QUANTITY_PARAM = "@Quantidade_Estoque";
        private const string PRODUCT_STATUS_PARAM = "@Status";

        private const string PRODUCT_INSERT_SQL = "INSERT INTO Tb_Produto (Codigo_Barra, Nome, Descricao, Unidade_Medida, Quantidade_Estoque, Status) VALUES (@Codigo_Barra, @Nome, @Descricao, @Unidade_Medida, @Quantidade_Estoque, @Status)";
        private const string PRODUCT_UPDATE_SQL = "UPDATE Tb_Produto SET Codigo_Barra = @Codigo_Barra, Nome = @Nome, Descricao = @Descricao, Unidade_Medida = @Unidade_Medida WHERE Id = @Id";
        private const string PRODUCT_UPDATE_STATUS_SQL = "UPDATE Tb_Produto SET Status = @Status WHERE Codigo_Barra = @Codigo_Barra";
        private const string PRODUCT_UPDATE_QUANTITY_SQL = "UPDATE Tb_Produto SET Quantidade_Estoque = @Quantidade_Estoque WHERE Codigo_Barra = @Codigo_Barra";
        private const string PRODUCT_GET_ID_SQL = "SELECT Id FROM Tb_Produto WHERE Codigo_Barra = @Codigo_Barra";
        private const string PRODUCT_GET_ALL_SQL = "SELECT Pro.Id, Pro.Codigo_Barra, Pro.Nome, Pro.Descricao, Pro.Unidade_Medida, Pre.Preco_Custo, Pre.Preco_Venda FROM Tb_Produto Pro, Tb_Preco Pre, (SELECT Pre2.Id_Produto, MAX(Pre2.Data_Hora) Max_Data_Hora FROM Tb_Preco Pre2 GROUP BY Pre2.Id_Produto) Tmp WHERE Pro.Id = Pre.Id_Produto AND Pro.Status = 1 AND Pre.Id_Produto = Tmp.Id_Produto AND Pre.Data_Hora = Tmp.Max_Data_Hora";
        private const string PRODUCT_GET_BY_BAR_CODE_SQL = "SELECT Pro.Id, Pro.Codigo_Barra, Pro.Nome, Pro.Descricao, Pro.Unidade_Medida, Pre.Preco_Custo, Pre.Preco_Venda FROM Tb_Produto Pro, Tb_Preco Pre, (SELECT Pre2.Id_Produto, MAX(Pre2.Data_Hora) Max_Data_Hora FROM Tb_Preco Pre2 GROUP BY Pre2.Id_Produto) Tmp WHERE Pro.Id = Pre.Id_Produto AND Pro.Codigo_Barra = @Codigo_Barra AND Pro.Status = 1 AND Pre.Id_Produto = Tmp.Id_Produto AND Pre.Data_Hora = Tmp.Max_Data_Hora";
        private const string PRODUCT_GET_BY_NAME_SQL = "SELECT Pro.Id, Pro.Codigo_Barra, Pro.Nome, Pro.Descricao, Pro.Unidade_Medida, Pre.Preco_Custo, Pre.Preco_Venda FROM Tb_Produto Pro, Tb_Preco Pre, (SELECT Pre2.Id_Produto, MAX(Pre2.Data_Hora) Max_Data_Hora FROM Tb_Preco Pre2 GROUP BY Pre2.Id_Produto) Tmp WHERE Pro.Id = Pre.Id_Produto AND Pro.Nome LIKE @Nome AND Pro.Status = 1 AND Pre.Id_Produto = Tmp.Id_Produto AND Pre.Data_Hora = Tmp.Max_Data_Hora";
        private const string PRODUCT_STOCK_GET_ALL_SQL = "SELECT Id, Codigo_Barra, Nome, Descricao, Quantidade_Estoque FROM Tb_Produto WHERE Status = 1";
        private const string PRODUCT_STOCK_GET_BY_BAR_CODE_SQL = "SELECT Id, Codigo_Barra, Nome, Descricao, Quantidade_Estoque FROM Tb_Produto WHERE Codigo_Barra = @Codigo_Barra AND Status = 1";
        private const string PRODUCT_STOCK_GET_BY_NAME_SQL = "SELECT Id, Codigo_Barra, Nome, Descricao, Quantidade_Estoque FROM Tb_Produto WHERE Nome LIKE @Nome AND Status = 1";

        #endregion

        #region -Price-

        private const string PRICE_TABLE = "Tb_Preco";

        private const string PRICE_ID_COLUMN = "Id";
        private const string PRICE_ID_PRODUCT_COLUMN = "Id_Produto";
        private const string PRICE_DATE_TIME_COLUMN = "Data_Hora";
        private const string PRICE_COST_PRICE_COLUMN = "Preco_Custo";
        private const string PRICE_SALE_PRICE_COLUMN = "Preco_Venda";

        private const string PRICE_ID_PARAM = "@Id";
        private const string PRICE_ID_PRODUCT_PARAM = "@Id_Produto";
        private const string PRICE_DATE_TIME_PARAM = "@Data_Hora";
        private const string PRICE_COST_PRICE_PARAM = "@Preco_Custo";
        private const string PRICE_SALE_PRICE_PARAM = "@Preco_Venda";

        private const string PRICE_INSERT_SQL = "INSERT INTO Tb_Preco (Id_Produto, Data_Hora, Preco_Custo, Preco_Venda) VALUES (@Id_Produto, @Data_Hora, @Preco_Custo, @Preco_Venda)";

        #endregion

        #region -Sale-

        private const string SALE_TABLE = "Tb_Venda";

        private const string SALE_ID_COLUMN = "Id";
        private const string SALE_ID_OPERATOR_COLUMN = "Id_Operador";
        private const string SALE_DATETIME_COLUMN = "Data_Hora";
        private const string SALE_SUBTOTAL_COLUMN = "Subtotal";
        private const string SALE_DISCOUNT_COLUMN = "Desconto";
        private const string SALE_TOTAL_COLUMN = "Total";

        private const string SALE_ID_PARAM = "@Id";
        private const string SALE_ID_OPERATOR_PARAM = "@Id_Operador";
        private const string SALE_DATETIME_PARAM = "@Data_Hora";
        private const string SALE_SUBTOTAL_PARAM = "@Subtotal";
        private const string SALE_DISCOUNT_PARAM = "@Desconto";
        private const string SALE_TOTAL_PARAM = "@Total";

        private const string SALE_INSERT_SQL = "INSERT INTO Tb_Venda (Id_Operador, Data_Hora, Subtotal, Desconto, Total) VALUES (@Id_Operador, @Data_Hora, @Subtotal, @Desconto, @Total)";
        private const string SALE_GET_ID_SQL = "SELECT Id FROM Tb_Venda WHERE Id_Operador = @Id_Operador AND Data_Hora = @Data_Hora";

        #endregion

        #region -Sale_Product-

        private const string SALE_PRODUCT_TABLE = "Tb_Venda_Produto";

        private const string SALE_PRODUCT_ID_COLUMN = "Id";
        private const string SALE_PRODUCT_ID_SALE_COLUMN = "Id_Venda";
        private const string SALE_PRODUCT_ID_PRODUCT_COLUMN = "Id_Produto";
        private const string SALE_PRODUCT_QUANTITY_COLUMN = "Quantidade";
        private const string SALE_PRODUCT_COST_PRICE_COLUMN = "Preco_Custo";
        private const string SALE_PRODUCT_SALE_PRICE_COLUMN = "Preco_Venda";

        private const string SALE_PRODUCT_ID_PARAM = "@Id";
        private const string SALE_PRODUCT_ID_SALE_PARAM = "@Id_Venda";
        private const string SALE_PRODUCT_ID_PRODUCT_PARAM = "@Id_Produto";
        private const string SALE_PRODUCT_QUANTITY_PARAM = "@Quantidade";
        private const string SALE_PRODUCT_COST_PRICE_PARAM = "@Preco_Custo";
        private const string SALE_PRODUCT_SALE_PRICE_PARAM = "@Preco_Venda";

        private const string SALE_PRODUCT_INSERT_SQL = "INSERT INTO Tb_Venda_Produto (Id_Venda, Id_Produto, Quantidade, Preco_Custo, Preco_Venda) VALUES (@Id_Venda, @Id_Produto, @Quantidade, @Preco_Custo, @Preco_Venda)";

        #endregion

        #endregion

        #region -Public Properties-

        public static string ProjectName
        {
            get { return PROJECT_NAME; }
        }

        #region -Operator-

        public static string OperatorTable
        {
            get { return OPERATOR_TABLE; }
        }

        public static string OperatorIdColumn
        {
            get { return OPERATOR_ID_COLUMN; }
        }

        public static string OperatorCodeColumn
        {
            get { return OPERATOR_CODE_COLUMN; }
        }

        public static string OperatorNameColumn
        {
            get { return OPERATOR_NAME_COLUMN; }
        }

        public static string OperatorPasswordColumn
        {
            get { return OPERATOR_PASSWORD_COLUMN; }
        }

        public static string OperatorStatusColumn
        {
            get { return OPERATOR_STATUS_COLUMN; }
        }

        public static string OperatorIdParam
        {
            get { return OPERATOR_ID_PARAM; }
        }

        public static string OperatorCodeParam
        {
            get { return OPERATOR_CODE_PARAM; }
        }

        public static string OperatorNameParam
        {
            get { return OPERATOR_NAME_PARAM; }
        }

        public static string OperatorPasswordParam
        {
            get { return OPERATOR_PASSWORD_PARAM; }
        }

        public static string OperatorStatusParam
        {
            get { return OPERATOR_STATUS_PARAM; }
        }

        public static string OperatorLoginSql
        {
            get { return OPERATOR_LOGIN_SQL; }
        }

        public static string OperatorInsertSql
        {
            get { return OPERATOR_INSERT_SQL; }
        }

        public static string OperatorUpdateSql
        {
            get { return OPERATOR_UPDATE_SQL; }
        }

        public static string OperatorUpdateStatusSql
        {
            get { return OPERATOR_UPDATE_STATUS_SQL; }
        }

        public static string OperatorGetAllSql
        {
            get { return OPERATOR_GET_ALL_SQL; }
        }

        public static string OperatorGetByIdSql
        {
            get { return OPERATOR_GET_BY_ID_SQL; }
        }

        public static string OperatorGetByCodeSql
        {
            get { return OPERATOR_GET_BY_CODE_SQL; }
        }

        public static string OperatorGetByNameSql
        {
            get { return OPERATOR_GET_BY_NAME_SQL; }
        }

        #endregion

        #region -Product-

        public static string ProductTable
        {
            get { return PRODUCT_TABLE; }
        }

        public static string ProductIdColumn
        {
            get { return PRODUCT_ID_COLUMN; }
        }

        public static string ProductBarCodeColumn
        {
            get { return PRODUCT_BAR_CODE_COLUMN; }
        }

        public static string ProductNameColumn
        {
            get { return PRODUCT_NAME_COLUMN; }
        }

        public static string ProductDescriptionColumn
        {
            get { return PRODUCT_DESCRIPTION_COLUMN; }
        }

        public static string ProductMeasurementUnitColumn
        {
            get { return PRODUCT_MEASUREMENT_UNIT_COLUMN; }
        }

        public static string ProductQuantityColumn
        {
            get { return PRODUCT_QUANTITY_COLUMN; }
        }

        public static string ProductStatusColumn
        {
            get { return PRODUCT_STATUS_COLUMN; }
        }

        public static string ProductIdParam
        {
            get { return PRODUCT_ID_PARAM; }
        }

        public static string ProductBarCodeParam
        {
            get { return PRODUCT_BAR_CODE_PARAM; }
        }

        public static string ProductNameParam
        {
            get { return PRODUCT_NAME_PARAM; }
        }

        public static string ProductDescriptionParam
        {
            get { return PRODUCT_DESCRIPTION_PARAM; }
        }

        public static string ProductMeasurementUnitParam
        {
            get { return PRODUCT_MEASUREMENT_UNIT_PARAM; }
        }

        public static string ProductQuantityParam
        {
            get { return PRODUCT_QUANTITY_PARAM; }
        }

        public static string ProductStatusParam
        {
            get { return PRODUCT_STATUS_PARAM; }
        }

        public static string ProductInsertSql
        {
            get { return PRODUCT_INSERT_SQL; }
        }

        public static string ProductUpdateSql
        {
            get { return PRODUCT_UPDATE_SQL; }
        }

        public static string ProductUpdateQuantitySql
        {
            get { return PRODUCT_UPDATE_QUANTITY_SQL; }
        }

        public static string ProductUpdateStatusSql
        {
            get { return PRODUCT_UPDATE_STATUS_SQL; }
        }

        public static string ProductGetIdSql
        {
            get { return PRODUCT_GET_ID_SQL; }
        }

        public static string ProductGetAllSql
        {
            get { return PRODUCT_GET_ALL_SQL; }
        }

        public static string ProductGetByBarCodeSql
        {
            get { return PRODUCT_GET_BY_BAR_CODE_SQL; }
        }

        public static string ProductGetByNameSql
        {
            get { return PRODUCT_GET_BY_NAME_SQL; }
        }

        public static string ProductStockGetAllSql
        {
            get { return PRODUCT_STOCK_GET_ALL_SQL; }
        }

        public static string ProductStockGetByBarCodeSql
        {
            get { return PRODUCT_STOCK_GET_BY_BAR_CODE_SQL; }
        }

        public static string ProductStockGetByNameSql
        {
            get { return PRODUCT_STOCK_GET_BY_NAME_SQL; }
        }

        #endregion

        #region -Price-

        public static string PriceTable
        {
            get { return PRICE_TABLE; }
        }

        public static string PriceIdColumn
        {
            get { return PRICE_ID_COLUMN; }
        }

        public static string PriceIdProductColumn
        {
            get { return PRICE_ID_PRODUCT_COLUMN; }
        }

        public static string PriceDateTimeColumn
        {
            get { return PRICE_DATE_TIME_COLUMN; }
        }

        public static string PriceCostPriceColumn
        {
            get { return PRICE_COST_PRICE_COLUMN; }
        }

        public static string PriceSalePriceColumn
        {
            get { return PRICE_SALE_PRICE_COLUMN; }
        }

        public static string PriceIdParam
        {
            get { return PRICE_ID_PARAM; }
        }

        public static string PriceIdProductParam
        {
            get { return PRICE_ID_PRODUCT_PARAM; }
        }

        public static string PriceDateTimeParam
        {
            get { return PRICE_DATE_TIME_PARAM; }
        }

        public static string PriceCostPriceParam
        {
            get { return PRICE_COST_PRICE_PARAM; }
        }

        public static string PriceSalePriceParam
        {
            get { return PRICE_SALE_PRICE_PARAM; }
        }

        public static string PriceInsertSql
        {
            get { return PRICE_INSERT_SQL; }
        }

        #endregion

        #region -Sale-

        public static string SaleTable
        {
            get { return SALE_TABLE; }
        }

        public static string SaleIdColumn
        {
            get { return SALE_ID_COLUMN; }
        }

        public static string SaleIdOperatorColumn
        {
            get { return SALE_ID_OPERATOR_COLUMN; }
        }

        public static string SaleDateTimeColumn
        {
            get { return SALE_DATETIME_COLUMN; }
        }

        public static string SaleSubtotalColumn
        {
            get { return SALE_SUBTOTAL_COLUMN; }
        }

        public static string SaleDiscountColumn
        {
            get { return SALE_DISCOUNT_COLUMN; }
        }

        public static string SaleTotalColumn
        {
            get { return SALE_TOTAL_COLUMN; }
        }

        public static string SaleIdParam
        {
            get { return SALE_ID_PARAM; }
        }

        public static string SaleIdOperatorParam
        {
            get { return SALE_ID_OPERATOR_PARAM; }
        }

        public static string SaleDateTimeParam
        {
            get { return SALE_DATETIME_PARAM; }
        }

        public static string SaleSubtotalParam
        {
            get { return SALE_SUBTOTAL_PARAM; }
        }

        public static string SaleDiscountParam
        {
            get { return SALE_DISCOUNT_PARAM; }
        }

        public static string SaleTotalParam
        {
            get { return SALE_TOTAL_PARAM; }
        }

        public static string SaleInsertSql
        {
            get { return SALE_INSERT_SQL; }
        }

        public static string SaleGetIdSql
        {
            get { return SALE_GET_ID_SQL; }
        }

        #endregion

        #region -Sale_Product-

        public static string SaleProductTable
        {
            get { return SALE_PRODUCT_TABLE; }
        }

        public static string SaleProductIdColumn
        {
            get { return SALE_PRODUCT_ID_COLUMN; }
        }

        public static string SaleProductIdSaleColumn
        {
            get { return SALE_PRODUCT_ID_SALE_COLUMN; }
        }

        public static string SaleProductIdProductColumn
        {
            get { return SALE_PRODUCT_ID_PRODUCT_COLUMN; }
        }

        public static string SaleProductQuantityColumn
        {
            get { return SALE_PRODUCT_QUANTITY_COLUMN; }
        }

        public static string SaleProductCostPriceColumn
        {
            get { return SALE_PRODUCT_COST_PRICE_COLUMN; }
        }

        public static string SaleProductSalePriceColumn
        {
            get { return SALE_PRODUCT_ID_SALE_COLUMN; }
        }

        public static string SaleProductIdParam
        {
            get { return SALE_PRODUCT_ID_PARAM; }
        }

        public static string SaleProductIdSaleParam
        {
            get { return SALE_PRODUCT_ID_SALE_PARAM; }
        }

        public static string SaleProductIdProductParam
        {
            get { return SALE_PRODUCT_ID_PRODUCT_PARAM; }
        }

        public static string SaleProductQuantityParam
        {
            get { return SALE_PRODUCT_QUANTITY_PARAM; }
        }

        public static string SaleProductCostPriceParam
        {
            get { return SALE_PRODUCT_COST_PRICE_PARAM; }
        }

        public static string SaleProductSalePriceParam
        {
            get { return SALE_PRODUCT_SALE_PRICE_PARAM; }
        }

        public static string SaleProductInsertSql
        {
            get { return SALE_PRODUCT_INSERT_SQL; }
        }

        #endregion

        #endregion
    }
}
