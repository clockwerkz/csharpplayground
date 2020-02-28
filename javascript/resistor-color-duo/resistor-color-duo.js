//
// This is only a SKELETON file for the 'Resistor Color Duo' exercise. It's been provided as a
// convenience to get you started writing code faster.
//
import { colorCode, Colors  } from './resistor-color';

export const decodedValue = (args) => {
  let num1 = Colors.indexOf(args[0].toLowerCase());
  let num2 = Colors.indexOf(args[1].toLowerCase());
  //Just putting in some error checking in case a color not on the list was passed
  return (num1 !== -1 && num2 !== -1) ? (num1 * 10) + num2 : -1;
};
