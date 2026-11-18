# W04 Foundation Programs Design

## YouTube Videos

Video stores video details and comments. Comment stores a person's name and text.

```text
Video
----------------------------------------
- _title: string
- _author: string
- _lengthInSeconds: int
- _comments: List<Comment>
----------------------------------------
+ Video(title, author, lengthInSeconds)
+ AddComment(comment: Comment): void
+ GetCommentCount(): int
+ Display(): void

Comment
----------------------------------------
- _name: string
- _text: string
----------------------------------------
+ Comment(name, text)
+ Display(): void
```

Explanation:
1. Main creates 3 videos, adds 3 comments to each, and puts the videos in a list.
2. Loop through the videos and call Display().
3. Display prints the title, author, seconds, and GetCommentCount() result.
4. GetCommentCount returns the list count; each Comment.Display prints its name and text.

## Online Ordering

Product tracks an item and its cost. Address stores an address and checks the country.
Customer stores a name and Address. Order holds a Customer and a list of Products.

```text
Product
----------------------------------------
- _name: string
- _productId: string
- _price: decimal
- _quantity: int
----------------------------------------
+ Product(name, productId, price, quantity)
+ GetName(): string
+ GetProductId(): string
+ GetTotalCost(): decimal

Address
----------------------------------------
- _streetAddress: string
- _city: string
- _stateOrProvince: string
- _country: string
----------------------------------------
+ Address(streetAddress, city, stateOrProvince, country)
+ IsInUSA(): bool
+ GetFullAddress(): string

Customer
----------------------------------------
- _name: string
- _address: Address
----------------------------------------
+ Customer(name, address)
+ GetName(): string
+ GetAddress(): string
+ IsInUSA(): bool

Order
----------------------------------------
- _customer: Customer
- _products: List<Product>
----------------------------------------
+ Order(customer)
+ AddProduct(product: Product): void
+ GetTotalCost(): decimal
+ GetPackingLabel(): string
+ GetShippingLabel(): string
```

Explanation:
1. Main creates 2 orders with 2 products each: one USA customer and one outside the USA.
2. For each order, print GetPackingLabel(), GetShippingLabel(), and GetTotalCost().
3. Packing labels list product names and IDs; shipping labels show the customer name and full address.
4. Product cost is price times quantity. Order total adds all product costs and shipping once: $5 for USA, otherwise $35.
5. Customer.IsInUSA calls Address.IsInUSA; Customer.GetAddress calls Address.GetFullAddress.
