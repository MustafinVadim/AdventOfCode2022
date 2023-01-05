import { V, Direction } from "./lib/extentions.js"


let set = new Set<V>();
var current = new V(0, 0);
set.add(current);


export function part1(input: string) {
    for (const step of input) {
        var next = current.getNeighbor(getDir(step));
        set.add(next);
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