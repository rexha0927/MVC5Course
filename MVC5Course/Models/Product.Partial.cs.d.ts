declare module server {
	interface Product {
	}
	interface ProductMetaData {
		productId: number;
		productName: string;
		price: number;
		active: boolean;
		stock: number;
		isDelete: boolean;
		orderLine: any[];
	}
}
