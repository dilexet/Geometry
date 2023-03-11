SELECT product.name AS 'Имя продукта', 
       category.name AS 'Имя категории'
FROM Products product
         LEFT JOIN ProductCategory pc
                   ON product.id = pc.productId
         LEFT JOIN Categories category
                   ON pc.categoryId = category.id
ORDER BY product.name, category.name