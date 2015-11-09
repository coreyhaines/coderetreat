<?php
require dirname(__FILE__) . '/../src/GameOfLife.php';

// Documentation at http://peridot-php.github.io/ and http://peridot-php.github.io/leo/expect.html

describe( 'GameOfLife', function() {
	it( 'should at least know right from wrong', function() {
		expect( true )->to->be->false;
	} );
} );
