import { failWhale } from "../fail-whale";

describe('print test', () => {
    it('can print without message', () => {
        console.error = jest.fn();
        console.log = jest.fn();
        failWhale('hello');
        expect(console.error).toHaveBeenCalled();
        expect(console.log).not.toHaveBeenCalled();
    });
});