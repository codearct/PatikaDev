-- SELECT * FROM film
-- WHERE title LIKE 'K%'
-- ORDER BY replacement_cost
-- LIMIT 4;

-- SELECT COUNT(*) FROM film
-- WHERE title ILIKE '%e%e%e%e%';

-- SELECT category.name,COUNT(*) FROM category
-- JOIN film_category ON film_category.category_id = category.category_id
-- GROUP BY category.name;

-- SELECT rating,COUNT(*) as cnt FROM film
-- GROUP BY rating
-- HAVING rating =ANY (SELECT DISTINCT(rating) FROM film)
-- ORDER BY cnt DESC
-- LIMIT 1;

-- SELECT first_name,last_name FROM customer
-- WHERE customer_id =
-- (
-- 	SELECT customer_id FROM payment
-- 	GROUP BY customer_id
-- 	HAVING customer_id=ANY
-- 	(
-- 		SELECT DISTINCT(customer_id) FROM payment
-- 	)
-- 	ORDER BY COUNT(payment_id) DESC
-- 	LIMIT 1
-- );

