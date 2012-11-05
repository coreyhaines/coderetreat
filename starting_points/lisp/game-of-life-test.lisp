(load "./lisp-unit.lisp")
(load "./game-of-life.lisp")

(use-package :lisp-unit)

(define-test "true is true"
    (assert-equal 't '()))

(run-tests)


