import { V, Direction } from "./lib/extentions.js"


let set = new Set<string>();
var current = new V(0, 0);
set.add(current.toString());


export function part1(input: string): number {
    doSteps([...input]);
    return set.size;
}

export function part2(input: string): number {
    let inputArray = [...input];
    let santa = inputArray.filter((_x, i) => i%2 === 0);
    let robot = inputArray.filter((_x, i) => i%2 !== 0);
    doSteps(santa);
    current = new V(0, 0);
    doSteps(robot);
    return set.size;
}

function doSteps(steps: Array<string>) {
    for (const step of steps) {
        var next = current.getNeighbor(getDir(step));
        set.add(next.toString());
        current = next;
    }
}

function getDir(dir: string): Direction {
    switch (dir) {
        case ">":
            return Direction.Right;
        case "<":
            return Direction.Left;
        case "^":
            return Direction.Up;
        case "v":
            return Direction.Down;
        default:
            throw new Error("error");
    }
}