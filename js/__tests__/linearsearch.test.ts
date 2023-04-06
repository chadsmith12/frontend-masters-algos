import { linearsearch} from '../src/algorithms/linearsearch';

describe('greeter function', () => {
  const values = [1,2,3,4,5];
  const correctValue = 1;
  const wrongValue = 10;

  // Assert if setTimeout was called properly
  it('returns true with a correct value', () => {
    const found = linearsearch(values, correctValue)
    expect(found).toBe(true)
  });

  // Assert greeter result
  it('returns false with a wrong value', () => {
    const found = linearsearch(values, wrongValue)
    expect(found).toBe(false)
  });
});
