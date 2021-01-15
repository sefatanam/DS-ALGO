const intReverse = require('./IntReversal');


test('ReverseInt function exists', () => {
    expect(intReverse).toBeDefined();
})

test('ReverseInt handles 0 as an input', () => {
    expect(intReverse(0)).toEqual(0);
});

test('IntReverse flips a positive number', () => {
    expect(intReverse(5)).toEqual(5);
    expect(intReverse(15)).toEqual(51);
    expect(intReverse(90)).toEqual(9);
    expect(intReverse(2359)).toEqual(9532);
});

test('IntReverse flips a negative number', () => {
    expect(intReverse(-5)).toEqual(-5);
    expect(intReverse(-15)).toEqual(-51);
    expect(intReverse(-90)).toEqual(-9);
    expect(intReverse(-2359)).toEqual(-9532);
});