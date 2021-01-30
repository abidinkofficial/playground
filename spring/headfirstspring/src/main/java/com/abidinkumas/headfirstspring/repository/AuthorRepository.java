package com.abidinkumas.headfirstspring.repository;

import com.abidinkumas.headfirstspring.model.Author;
import org.springframework.data.repository.CrudRepository;

public interface AuthorRepository extends CrudRepository<Author, Long> {
}
