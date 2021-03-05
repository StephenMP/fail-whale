import { failWhale } from "../fail-whale";

describe('print test', () => {
    it('can print without message', () => {
        console.error = jest.fn();
        console.log = jest.fn();
        failWhale();
        expect(console.error).toHaveBeenCalledTimes(4);
        expect(console.log).not.toHaveBeenCalled();
    });

    it('can take custom logger', () => {
        const logWarn = {
            error: (msg: any) => console.warn(msg)
        }
        logWarn.error = jest.fn();
        console.error = jest.fn();
        console.log = jest.fn();
        failWhale('hello', logWarn);
        expect(console.error).not.toHaveBeenCalled();
        expect(console.log).not.toHaveBeenCalled();
        expect(logWarn.error).toHaveBeenCalledTimes(5);
    });
});