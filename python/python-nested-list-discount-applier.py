# List of lists containing products and their prices
# Liste içinde liste yapısı ile ürün ve fiyat işlemleri

urunler = [["ayakkabi", 100], ["pantolon", 200], ["gomlek", 150], ["canta", 250], ["saat", 300]]

def indirim(x):
    # x[0] -> product name, x[1] -> original price
    # Apply 10% discount (multiply by 0.9)
    urun, fiyat = x[0], x[1] * 0.9
    return [urun, fiyat]


indirimli_urunler = list(map(indirim, urunler))

print(f"İndirimli Ürünler / Discounted Products: {indirimli_urunler}")
