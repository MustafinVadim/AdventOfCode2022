export function part1(input: string): number {
    return [...input].map(x => x == '(' ? 1 : -1).reduce((acc, x) => acc + x, 0);
}

export function part2(input: string): number {

    const arr = [...input];
    let acc = 0;
    for (let i = 0; i <input.length; i++) {
        const current = arr[i];
        acc += current == '(' ? 1 : -1;
        if (acc == -1) return i + 1;
    }

    return -1;
}