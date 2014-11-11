var gameOfLife = require('../coderetreat');
var expect = require('chai').expect;

describe('coderetreat.spec.js', function () {
	var result;

	describe('when running', function () {
		beforeEach(function () {
			result = gameOfLife.run();
		});

		it('should return 0', function () {
			expect(result).to.equal(0);
		});
	});

});