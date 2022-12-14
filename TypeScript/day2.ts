export const part1 = (input: string[]): number => calc(input, alg1);
export const part2 = (input: string[]): number => calc(input, alg2);

const calc = (input: string[], alg: Function): number => input
            .map(i => i.split('x'))
            .map(i => alg(i))
            .reduce((acc, i) => acc + i, 0);

const alg1 = (box: string[]): number => {
    const sides = [+box[0], +box[1], +box[2]].sort((a, b) => a - b);
    const sqare = 2 * (sides[1] * (sides[0] + sides[2]) + sides[2] * sides[0]);
    return sides[0] * sides[1] + sqare;
}

const alg2 = function (box: string[]): number {
    const sides = [+box[0], +box[1], +box[2]].sort((a, b) => a - b);;
    return 2 * (sides[0] + sides[1]) + sides[0] * sides[1] * sides[2];
}