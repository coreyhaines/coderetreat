describe('coderetreat.spec.js', function () {
	var result;

	describe('when running', function () {
		beforeEach(function () {
			result = gameOfLife.run();
		});

		it('should return 0', function () {
			expect(result).toEqual(0);
		});
	});

});