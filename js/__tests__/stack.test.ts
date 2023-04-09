import { Stack } from '../src/datastructures/Stack.js';

describe('Stack data structure', () => {
  it('Pushing a single value will give a length of 1', () => {
    const stack = new Stack<number>();
    stack.push(1);

    expect(stack.length).toBe(1);
  });

  it('Pushing two values will give a length of 2', () => {
    const stack = new Stack<number>();
    stack.push(1);
    stack.push(2);

    expect(stack.length).toBe(2);
  })

  it('Popping will give the last value pushed back', () => {
    const stack = new Stack<number>();
    stack.push(1);
    stack.push(2);
    stack.push(4);

    const result = stack.pop();

    expect(result).toBe(4);
  })

  it('Popping an empty stack will give undefined', () => {
    const stack = new Stack<number>();
    const result = stack.pop();

    expect(result).toBe(undefined)
  })

  it('Peek will give first value and not change length', () => {
    const stack = new Stack<number>();
    stack.push(1);
    stack.push(2);

    const result = stack.peek();

    expect(result).toBe(2);
    expect(stack.length).toBe(2);
  })

  it('Peeking an empty stack will give undefined', () => {
    const stack = new Stack<number>();
    const result = stack.peek();

    expect(result).toBe(undefined)
  })
});
