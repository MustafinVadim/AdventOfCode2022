export class V {
    x: number;
    y: number;

    constructor(x: number, y: number) {
        this.x = x;
        this.y = y;
    }

    getNeighbor(direction: Direction){
        switch (direction) {
            case Direction.Up:
                return new V(this.x, this.y + 1);
            case Direction.Down:
                return new V(this.x, this.y - 1);
            case Direction.Left:
                return new V(this.x - 1, this.y);
            case Direction.Right:
                return new V(this.x + 1, this.y);
        }
    }

    public toString = () => `{${this.x}; ${this.y}}`;
}

export enum Direction {
    Up,
    Down,
    Left,
    Right
}
