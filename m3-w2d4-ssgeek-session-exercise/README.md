# SESSION

You'll be creating a shopping cart that allows your website visitor the ability to view products, select a product, and add it to the their shopping cart.

**You should unit test when possible**

## Product List Page

The product listing page displays all of the inventory that the SSGeek shop contains (product data is available in `scripts/ssgeek-shopping-cart.sql`).

**Requirements**

- When the user clicks on the image of a product they are navigated to the **Product Detail** page
- Use the URL pattern `/ShoppingCart/Index` 

![Product List Page](etc/products.png)

## Product Detail Page

The product detail page displays the data for a specific product and allows users to add products to their shopping cart.

**Requirements**

- When the user enters a quantity into the textbox and *presses Enter* or *presses Add to Cart* the product is added to their shopping cart
- After the user adds an item to their shopping cart, they are redirected to the View Cart page
- Use the URL pattern `/ShoppingCart/Detail/{product-id}`

![Product Detail Page](etc/product_detail.png)

## View Shopping Cart

The View Shopping Cart page displays all of the items that are in the visitor's shopping cart to purchase.

**Requirements**

- Use the URL pattern `/ShoppingCart/ViewCart`

![Shopping Cart](etc/view_cart.png)


