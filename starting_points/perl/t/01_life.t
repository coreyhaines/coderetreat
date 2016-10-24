use strict;
use warnings;
use 5.010;

##  Instruct the test harness how many tests you expect so it can
##  number them. This doesn't *have* to be correct, but you'll get a
##  warning if it does not match.
use Test::Simple tests => 2;

## This is the module we're testing
use Life qw(get_true get_false);

my $true = get_true;
my $false = get_false;

## Two simple tests to show tests passing and failing. 'ok' passes if
## the argument is true, and fails if it is false.

ok( $true == $true );
ok( $true == $false );
