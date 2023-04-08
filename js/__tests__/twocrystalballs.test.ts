import { twoCrystalBalls } from '../src/algorithms/crystalballs.js';

describe('greeter function', () => {
  const values = [false, false, false, true, true, true];
  const correctValue = 3;

  // Assert if setTimeout was called properly
  it('returns true with a correct value', () => {
    const found = twoCrystalBalls(values)
    expect(found).toBe(correctValue)
  });
});
