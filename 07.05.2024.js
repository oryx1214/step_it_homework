//task1

let shoppingList = [];

function ShowShoppingList() {
    console.log("Список покупок:");

    let unpurchased = [];
    let purchased = [];

    shoppingList.ForEach(item => {
        if (item.bought) {
            purchased.push(item);
        } else {
            unpurchased.push(item);
        }
    });

    console.log("Некупленные:");
    unpurchased.ForEach(item => {
        console.log(`${item.name} - ${item.quantity}`);
    });

    console.log("Купленные:");
    purchased.ForEach(item => {
        console.log(`${item.name} - ${item.quantity}`);
    });
}

function AddItemToShoppingList(productName, quantity) {
    let found = false;
    shoppingList.ForEach(item => {
        if (item.name === productName) {
            item.quantity += quantity;
            found = true;
        }
    });

    if (!found) {
        shoppingList.push({
            name: productName,
            quantity: quantity,
            bought: false
        });
    }

    console.log(`${quantity} ${productName} добавлено в список.`);
}

function BuyProduct(productName) {
    shoppingList.ForEach(item => {
        if (item.name === productName) {
            item.bought = true;
            console.log(`${productName} отмечен как купленный.`);
        }
    });
}

//task2

let receipt = [
    { name: "Шоколад", quantity: 3, pricePerUnit: 25 },
    { name: "Фольга", quantity: 1, pricePerUnit: 50 },
    { name: "Бутылка", quantity: 2, pricePerUnit: 15 },
    { name: "Бананы", quantity: 4, pricePerUnit: 10 }
];

function printReceipt() {
    console.log("Чек:");
    receipt.forEach(item => {
        console.log(`${item.name} - ${item.quantity} - ${item.pricePerUnit} манат за штуку`);
    });
}

function calculateTotal() {
    let total = 0;
    receipt.forEach(item => {
        total += item.quantity * item.pricePerUnit;
    });
    return total;
}

function findMostExpensiveItem() {
    let maxPrice = 0;
    let mostExpensiveItem = null;
    receipt.forEach(item => {
        let totalPrice = item.quantity * item.pricePerUnit;
        if (totalPrice > maxPrice) {
            maxPrice = totalPrice;
            mostExpensiveItem = item;
        }
    });
    return mostExpensiveItem;
}

function calculateAveragePrice() {
    let totalQuantity = 0;
    let totalPrice = 0;
    receipt.forEach(item => {
        totalQuantity += item.quantity;
        totalPrice += item.quantity * item.pricePerUnit;
    });
    if (totalQuantity === 0) {
        return 0; 
    }
    return totalPrice / totalQuantity;
}

printReceipt();

let total = calculateTotal();
console.log(`Общая сумма покупки: ${total} руб.`);

let expensiveItem = findMostExpensiveItem();
console.log(`Самая дорогая покупка: ${expensiveItem.name} - ${expensiveItem.quantity} шт. - ${expensiveItem.pricePerUnit} манат за штуку`);

let averagePrice = calculateAveragePrice();
console.log(`Средняя стоимость одного товара в чеке: ${averagePrice.toFixed(2)} манат`);


//task 3

let styles = [
    { name: "color", value: "blue" },
    { name: "font-size", value: "18px" },
    { name: "text-align", value: "center" },
    { name: "text-decoration", value: "underline" }
];

function writeStyledText(text, styles) {
    let styleString = styles.map(style => `${style.name}: ${style.value};`).join(' ');

    document.write(`<p style="${styleString}">${text}</p>`);
}

writeStyledText("Пример текста с примененными стилями", styles);
