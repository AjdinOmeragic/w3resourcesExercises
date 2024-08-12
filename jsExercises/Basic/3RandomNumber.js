function getRandomNumber(min, max) {
  return Math.random() * (max - min) + min;
}

// Example usage:
let randomNum = getRandomNumber(1, 100);
console.log(randomNum);
