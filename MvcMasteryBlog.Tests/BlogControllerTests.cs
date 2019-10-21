using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using Microsoft.AspNetCore.Mvc;
using MvcMasteryBlog.Controllers;
using MvcMasteryBlog.Models;
using MvcMasteryBlog.Repositories;
using Xunit;

namespace MvcMasteryBlog.Tests
{
    public class BlogControllerTests
    {
        BlogController underTest;
        IRepository<Blog> blogRepo;

        public BlogControllerTests()
        {
            blogRepo = Substitute.For<IRepository<Blog>>();
            underTest = new BlogController(blogRepo);
        }

        [Fact]
        public void Index_Returns_View_Result()
        {

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Blogs_To_View()
        {
            var expectedBlogs = new List<Blog>();
            blogRepo.GetAll().Returns(expectedBlogs);

            var result = underTest.Index();

            Assert.Equal(expectedBlogs, result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Blog_To_View()
        {
            var expectedProducts = new Blog();
            blogRepo.GetByID(1).Returns(expectedProducts);

            var result = underTest.Details(1);

            Assert.Equal(expectedProducts, result.Model);
        }
    }


}
