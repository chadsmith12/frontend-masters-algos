import { quicksort } from '../src/algorithms/quicksort.js';

describe('Quick Sort Algorithm', () => {
  const values = [4,2,9,1,5];

  // Assert if setTimeout was called properly
  it('will sort the values in memory', () => {
    quicksort(values);
    expect(values).toStrictEqual([1,2,4,5,9]);
  });
});
