export function quicksort(values: number[]) {
    quicksortInternal(values, 0, values.length - 1);
}

function quicksortInternal(values: number[], low: number, high: number) {
    if (low >= high) {
        return;
    }

    const pivotIndex = partition(values, low, high);
    quicksortInternal(values, low, pivotIndex - 1);
    quicksortInternal(values, pivotIndex + 1, high);
}

function partition(values: number[], low: number, high: number): number {
    const pivot = values[high];
    let index = low - 1;

    for(let i = low; i < high; ++i) {
        if (values[i] <= pivot) {
            index++;
            const temp = values[i];
            values[i] = values[index];
            values[index] = temp;
        }
    }

    index++;
    values[high] = values[index];
    values[index] = pivot;

    return index;
}