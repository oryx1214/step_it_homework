//#region task1

const car = {
  make: "Mercedes",
  model: "AMG E63 S",
  year: 2023,
  average_speed: 90,
};
function Info(car) {
  console.log(`Производитель: ${car.make}`);
  console.log(`Модель: ${car.model}`);
  console.log(`Год выпуска: ${car.year}`);
  console.log(`Средняя скорость: ${car.average_speed} км/ч`);
}

Info(car);

function calculate(distance) {
  const hours = distance / car.average_speed;
  const restPeriods = Math.floor(hours / 4);
  const totalHours = hours + restPeriods;
  return totalHours;
}

const distance = 200;
const travelTime = calculate(distance);
console.log(`Время в пути: ${travelTime.toFixed(2)} часов`);

//#region task2

function gcd(a, b) {
  return b === 0 ? a : gcd(b, a % b);
}
class Fraction {
  constructor(numerator, denominator)
   {
      this.n = numerator;
      this.d = denominator; 
  }
  add(other) 
  {
      return new Fraction(
          this.n * other.d + other.n * this.d,
          this.d * other.d
      ).reduce();
  }
  subtract(other) 
  {
      return new Fraction(
          this.n * other.d - other.n * this.d,
          this.d * other.d
      ).reduce();
  }
  multiply(other)
   {
      return new Fraction(
          this.n * other.n,
          this.d * other.d
      ).reduce();
  }
  divide(other) 
  {
      return new Fraction(
          this.n * other.d,
          this.d * other.n
      ).reduce();
  }
  reduce() 
  {
      const commonDivisor = gcd(this.n, this.d);
      return new Fraction(this.n / commonDivisor, this.d / commonDivisor);
  }
  toString() 
  {
      return `${this.n}/${this.d}`;
  }
}

//#region task3

const Time = {
  hours: 0,
  minutes: 0,
  seconds: 0,

  printTime: function() {
      let hoursStr = this.hours.toString().padStart(2, '0');
      let minutesStr = this.minutes.toString().padStart(2, '0');
      let secondsStr = this.seconds.toString().padStart(2, '0');
      console.log(`${hoursStr}:${minutesStr}:${secondsStr}`);
  },

  changeSeconds: function(seconds) {
      this.seconds += seconds;
      this.normalizeTime();
  },

  changeMinutes: function(minutes) {
      this.minutes += minutes;
      this.normalizeTime();
  },

  changeHours: function(hours) {
      this.hours += hours;
      this.normalizeTime();
  },

  normalizeTime: function() {
      let extraMinutes = Math.floor(this.seconds / 60);
      this.seconds = this.seconds % 60;
      this.minutes += extraMinutes;

      let extraHours = Math.floor(this.minutes / 60);
      this.minutes = this.minutes % 60;
      this.hours += extraHours;

      this.hours = this.hours % 24; 
  }
};
