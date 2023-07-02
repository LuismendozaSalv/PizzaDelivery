
# Pizza Delivery

Proyecto realizado para la práctica e implementación de patrones de diseño.



## API Reference

### Obtener todas las pizzas

```http
  GET /api/Pizza/GetPizzas
```
#### Reponse
```json
[
  {
    "pizzaId": 1,
    "nombre": "Margarita",
    "price": 42
  },
  {
    "pizzaId": 2,
    "nombre": "Cheeseburger",
    "price": 48
  },
  {
    "pizzaId": 3,
    "nombre": "Personalizada",
    "price": 60
  }
]

```

### Obtener todos los ingredientes

```http
  GET /api/Topping/GetToppings
```
```json
[
  {
    "id": 1,
    "nombre": "Choclo"
  },
  {
    "id": 2,
    "nombre": "Mortadela"
  },
  {
    "id": 3,
    "nombre": "Cheedar"
  },
  {
    "id": 4,
    "nombre": "Pepperoni"
  },...
]
```
### Realizar pedido de pizzas

```http
  POST /api/Pedido/MakeOrder
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `nombreCliente`      | `string` | **Required**. Nombre de cliente |
| `makePizzas`      | `List<MakePizzaRequest>` | **Required**. List of items to fetch |

###### MakePizzaRequest

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `pizzaId`      | `int` | **Required**. Id de pizza de la lista de pizzas|
| `toppingsIds`      | `List<int>` | **Required**. List of items to fetch |

#### Ejemplo

```json

{
  "nombreCliente": "Luis Mendoza",
  "makePizzas": [
    {
      "pizzaId": 1,
      "toppingsIds": [
        0
      ]
    },
    {
      "pizzaId": 3,
      "toppingsIds": [
        1,2,3
      ]
    }
  ]
}

```
#### Response
```json

{
  "pedidoId": 1,
  "pedidoDetail": "Pedido: 1;Nombre cliente: Luis Mendoza;Precio Total: 112;Estado: PENDIENTE;Pizzas: Pizza: Pizza Margarita;Precio: 42;Ingredientes: Albahaca, Tomates, Pizza: Pizza personalizada;Precio: 60;Ingredientes: Choclo, Mortadela, Cheedar"
}

```

### Obtener todos los ingredientes

```http
  POST /api/Pedido/GetOrder?${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id |

#### Ejemplo
https://localhost:7209/api/Pedido/GetOrder?id=1

#### Response
```json

{
  "pedidoId": 1,
  "pedidoDetail": "Pedido: 1;Nombre cliente: Luis Mendoza;Precio Total: 112;Estado: PENDIENTE;Pizzas: Pizza: Pizza Margarita;Precio: 42;Ingredientes: Albahaca, Tomates, Pizza: Pizza personalizada;Precio: 60;Ingredientes: Choclo, Mortadela, Cheedar"
}
```
### Procesar pedido
```http
  POST /api/Pedido/ProcesarPedido?${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id |

#### Ejemplo
https://localhost:7209/api/Pedido/ProcesarPedido?id=1

#### Response
```json

{
  "pedidoId": 1,
  "pedidoDetail": "Pedido: 1;Nombre cliente: Luis Mendoza;Precio Total: 112;Estado: CONFIRMADO;Pizzas: Pizza: Pizza Margarita;Precio: 42;Ingredientes: Albahaca, Tomates, Pizza: Pizza personalizada;Precio: 60;Ingredientes: Choclo, Mortadela, Cheedar"
}
```
### Cancelar pedido

```http
  POST /api/Pedido/CancelarPedido?${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id |

#### Ejemplo
https://localhost:7209/api/Pedido/ProcesarPedido?id=1

#### Response
```json

{
  "pedidoId": 1,
  "pedidoDetail": "Pedido: 1;Nombre cliente: Luis Mendoza;Precio Total: 112;Estado: CANCELADO;Pizzas: Pizza: Pizza Margarita;Precio: 42;Ingredientes: Albahaca, Tomates, Pizza: Pizza personalizada;Precio: 60;Ingredientes: Choclo, Mortadela, Cheedar"
}
```
## Authors

- [@LuismendozaSalv](https://github.com/LuismendozaSalv)

