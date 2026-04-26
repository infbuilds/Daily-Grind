# List of lists containing products and their prices
# Liste içinde liste yapısı ile ürün ve fiyat işlemleri


products = [["shoes", 100], ["trousers", 200], ["shirt", 150], ["bag", 250], ["watch", 300]]

def apply_discount(x):
    # x[0] is the product name, x[1] is the original price
    # Multiplying by 0.9 results in a 10% discount
    product, price = x[0], x[1] * 0.9
    return [product, price]


discounted_products = list(map(apply_discount, products))

print(f"Discounted Products List: {discounted_products}")
