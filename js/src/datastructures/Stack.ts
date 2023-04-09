type StackNode<T> = {
    value: T
    previous?: StackNode<T>
}

export class Stack<T> {
    public length: number;
    private tail?: StackNode<T>

    constructor() {
        this.length = 0;
        this.tail = undefined;
    }

    public push(value: T) {
        const node: StackNode<T> = { value: value }
        this.length++;

        if (!this.tail) {
            this.tail = node;
            return;
        }

        const tail = this.tail;
        this.tail = node;
        this.tail.previous = tail;
    }

    public pop(): T | undefined {
        if (this.length === 0) {
            return undefined;
        }

        this.length--;
        const tail = this.tail;
        this.tail = tail?.previous;

        return tail?.value
    }

    public peek(): T | undefined {
        return this.tail?.value;
    }
}