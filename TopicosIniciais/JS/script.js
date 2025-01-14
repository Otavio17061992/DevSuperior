class Product {
  constructor(name, price, quantity) {
    (this.name = name), (this.price = price), (this.quantity = quantity);
  }

  toString() {
    return `${this.name},${this.price.toFixed(2)},${this.quantity}`;
  }

  total() {
    return this.price * this.quantity;
  }
  updatePrice(percentage) {
    this.price *= 1 + percentage / 100;
  }
}

const p1 = new Product("Laptop", 1000.0, 5);
const p2 = new Product("PC", 2000, 2);

const total1 = p1.total();
const total2 = p2.total();
p1.updatePrice(10);

console.log(total1);
console.log(total2);
console.log(p1.price);
