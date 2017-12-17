var server = server || {};
/// <summary>The Product class as defined in MVC5Course.Models.Product</summary>
server.Product = function() {
};

/// <summary>The ProductMetaData class as defined in MVC5Course.Models.ProductMetaData</summary>
server.ProductMetaData = function() {
	/// <field name="productId" type="Number">The ProductId property as defined in MVC5Course.Models.ProductMetaData</field>
	this.productId = 0;
	/// <field name="productName" type="String">The ProductName property as defined in MVC5Course.Models.ProductMetaData</field>
	this.productName = '';
	/// <field name="price" type="Number">The Price property as defined in MVC5Course.Models.ProductMetaData</field>
	this.price = 0;
	/// <field name="active" type="Boolean">The Active property as defined in MVC5Course.Models.ProductMetaData</field>
	this.active = false;
	/// <field name="stock" type="Number">The Stock property as defined in MVC5Course.Models.ProductMetaData</field>
	this.stock = 0;
	/// <field name="isDelete" type="Boolean">The IsDelete property as defined in MVC5Course.Models.ProductMetaData</field>
	this.isDelete = false;
	/// <field name="orderLine" type="Object[]">The OrderLine property as defined in MVC5Course.Models.ProductMetaData</field>
	this.orderLine = [];
};

