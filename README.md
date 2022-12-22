# Вопрос №2: 
###   Библиотека вычисляющая площадь круга и треугольника.
###  Тесты библиотеки тоже реализован 
### В библиотеке есть класс Find_Area_Figure этот класс с помощью метода find_area и вычисляет площадь фигур. 

--------------------------------------------------

# Вопрос №3: 
### в этое базе прослеживается связь “many to many” для этого нужна связующая таблица, допустим назовем ее “product_category”, тогда запрос будет такой:

###   SELECT product.name, category.name 
###   FROM product
###   LEFT JOIN product_category ON product.id == product_category.product_id 
###   LEFT JOIN category ON category.id == product_category.category_id;







