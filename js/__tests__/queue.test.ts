import { Queue } from '../src/datastructures/Queue.js';

describe('Queue data structure', () => {
  it('Enqueing a single value will give a length of 1', () => {
    const queue = new Queue<number>();
    queue.enqueue(1);

    expect(queue.length).toBe(1);
  });

  it('Enqueing two values will give a length of 2', () => {
    const queue = new Queue<number>();
    queue.enqueue(1);
    queue.enqueue(2);

    expect(queue.length).toBe(2);
  })

  it('Dequeing will give the first value back', () => {
    const queue = new Queue<number>();
    queue.enqueue(1);
    queue.enqueue(2);
    queue.enqueue(4);

    const result = queue.deque();

    expect(result).toBe(1);
  })

  it('Dequeing an empty queue will give undefined', () => {
    const queue = new Queue<number>();
    const result = queue.deque();

    expect(result).toBe(undefined)
  })

  it('Peek will give first value and not change length', () => {
    const queue = new Queue<number>();
    queue.enqueue(1);
    queue.enqueue(2);

    const result = queue.peek();

    expect(result).toBe(1);
    expect(queue.length).toBe(2);
  })

  it('Peeking an empty queue will give undefined', () => {
    const queue = new Queue<number>();
    const result = queue.peek();

    expect(result).toBe(undefined)
  })
});
