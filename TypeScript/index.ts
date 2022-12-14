import * as solve from "./day2.js";
import { getInput } from "./lib/input.js";

const input = await getInput(2015, 2);

console.log(solve.part2(input.split("\n").filter(Boolean)));