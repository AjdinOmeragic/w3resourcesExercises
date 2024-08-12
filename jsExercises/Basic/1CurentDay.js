const currentDate = new Date();

const days = [
  "Monday",
  "Tuesday",
  "Wendsday",
  "Thursday",
  "Friday",
  "Saturday",
  "Sunday",
];
const day = days[currentDate.getDate()];

const hours = currentDate.getHours();
const minutes = currentDate.getMinutes();
const seconds = currentDate.getSeconds();

const formattedMinutes = minutes < 10 ? `0${minutes}` : minutes;
const formattedSeconds = seconds < 10 ? `0${seconds}` : seconds;

console.log(`Today is: ${day}`);
console.log(
  `Current time is: ${hours}:${formattedMinutes}:${formattedSeconds}`
);
