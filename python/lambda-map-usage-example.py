# Üç farklı listedeki aynı sıradaki elemanları toplayan uygulama
# A script to sum elements from three different lists using map and lambda

list = [1, 2, 3, 4]
list2 = [5, 6, 7, 8]
list3 = [9, 10, 11, 12]


total = list(map(lambda x, y, z: x + y + z, list, list2, list3))


print(f"Sonuç Listesi / Result List: {total}")
