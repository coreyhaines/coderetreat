package Life;

use strict;
use warnings;
use 5.010;

# Optional: list functions to export
use base 'Exporter';
our @EXPORT_OK = qw(get_true get_false);

sub get_true {
  return 1;
}

sub get_false {
  return 0;
}

1;
