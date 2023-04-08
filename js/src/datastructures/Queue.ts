type Node<T> = {
    value: T
    next?: Node<T>
}

export class Queue<T> {
    public length: number;
    private head?: Node<T>;
    private tail?: Node<T>;

    constructor() {
        this.length = 0;
        this.head = this.tail = undefined;
    }

    public enqueue(item: T) {
        const node: Node<T> = { value: item }
        this.length++;
        if (!this.tail) {
            this.tail = this.head = node;
            return;
        }

        this.tail.next = node;
        this.tail = node;
    }

    public deque(): T | undefined {
        if (!this.head) {
            return undefined;
        }

        this.length--;
        // save a reference to the current head value
        const head = this.head;
        // head now will point to the next value
        this.head = this.head.next;

        head.next = undefined;

        if (this.length == 0) {
            this.tail = undefined
        }

        return head.value
    }

    public peek(): T | undefined {
        if (!this.head) {
            return undefined;
        }

        return this.head.value
    }
}