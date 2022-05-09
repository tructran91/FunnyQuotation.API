using FunnyQuotation.Application.Infrastructure;
using FunnyQuotation.Domain.Entities;

namespace FunnyQuotation.Infrastructure.Data
{
    public static class ApplicationDbContextSeed
    {
        //public static async Task SeedRolesAsync(MyRoleManager roleManager)
        //{
        //    var hasAdminRole = await roleManager.RoleExistsAsync(Constants.ADMIN_ROLE);
        //    if (!hasAdminRole)
        //    {
        //        await roleManager.CreateAsync(new IdentityRole(Constants.ADMIN_ROLE));
        //    }

        //    var hasSystemRole = await roleManager.RoleExistsAsync(Constants.SYSTEM_ROLE);
        //    if (!hasSystemRole)
        //    {
        //        await roleManager.CreateAsync(new IdentityRole(Constants.SYSTEM_ROLE));
        //    }

        //    var hasUserRole = await roleManager.RoleExistsAsync(Constants.USER_ROLE);
        //    if (!hasSystemRole)
        //    {
        //        await roleManager.CreateAsync(new IdentityRole(Constants.USER_ROLE));
        //    }

        //}

        //public static async Task SeedDefaultUserAsync(MyUserManager userManager)
        //{
        //    var admin = new Author
        //    {
        //        UserName = "trungtruc.tran91@gmail.com",
        //        Name = "Trực Trần",
        //        Slug = "Trực Trần".Slugify(),
        //        Email = "trungtruc.tran91@gmail.com",
        //        Created = DateTime.Now
        //    };
        //    if (userManager.Users.All(u => u.UserName != admin.UserName))
        //    {
        //        var createAdmin = await userManager.CreateAsync(admin, Constants.DEFAULT_PASSWORD);
        //        if (createAdmin.Succeeded)
        //        {
        //            await userManager.AddToRoleAsync(admin, Constants.ADMIN_ROLE);
        //            await userManager.AddToRoleAsync(admin, Constants.SYSTEM_ROLE);
        //        }
        //    }

        //    var defaultUser = new Author
        //    {
        //        UserName = "default@gmail.com",
        //        Name = "Sưu tầm",
        //        Slug = "Sưu tầm".Slugify(),
        //        Email = "default@gmail.com",
        //        Created = DateTime.Now
        //    };
        //    if (userManager.Users.All(u => u.UserName != defaultUser.UserName))
        //    {
        //        var createDefaultUser = await userManager.CreateAsync(defaultUser, Constants.DEFAULT_PASSWORD);
        //        if (createDefaultUser.Succeeded)
        //        {
        //            await userManager.AddToRoleAsync(defaultUser, Constants.SYSTEM_ROLE);
        //        }
        //    }

        //    var vlog1977User = new Author
        //    {
        //        UserName = "1977@gmail.com",
        //        Name = "1977 Vlog",
        //        Slug = "1977 Vlog".Slugify(),
        //        Email = "1977@gmail.com",
        //        Created = DateTime.Now
        //    };
        //    if (userManager.Users.All(u => u.UserName != vlog1977User.UserName))
        //    {
        //        var createDefaultUser = await userManager.CreateAsync(vlog1977User, Constants.DEFAULT_PASSWORD);
        //        if (createDefaultUser.Succeeded)
        //        {
        //            await userManager.AddToRoleAsync(vlog1977User, Constants.SYSTEM_ROLE);
        //        }
        //    }
        //}

        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "18+", Slug = "18+".Slugify(), Description = "Bậy bạ bựa bẩn bấy bá", ThumbnailURL = "img/cate/18.jpg", IsPublished = true, IsFavorite = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Ăn uống", Slug = "Ăn uống".Slugify(), Description = "Có thực mới zựt được đồ ", ThumbnailURL = "img/cate/dish.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Bạn bè", Slug = "Bạn bè".Slugify(), Description = "Tình bạn đôi khi còn lãng mạn hơn tình yêu", ThumbnailURL = "img/cate/friend.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Bạn thừa biết", Slug = "Bạn thừa biết".Slugify(), Description = "Có thể bạn thừa biết", ThumbnailURL = "img/cate/pacman.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Ca dao tục, ngữ", Slug = "Ca dao tục, ngữ".Slugify(), Description = "Vạn sự khởi đầu nan, gian nan bắt đầu nản", ThumbnailURL = "img/cate/suu-nhi.jpeg", IsPublished = true, IsFavorite = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Cha mẹ", Slug = "Cha mẹ".Slugify(), Description = "Có 1 người phụ nữ luôn yêu tôi đến hết cuộc đời… Đó chính là MẸ CỦA TÔI.", ThumbnailURL = "img/cate/cha-me.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Chia tay", Slug = "Chia tay".Slugify(), Description = "Tại sao lại chia tay ... anh làm điều gì sai :(", ThumbnailURL = "img/cate/heart-broken.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Chưa phân loại", Slug = "Chưa phân loại".Slugify(), Description = "Tổng hợp, collection, mashup, ... chưa phân loại", ThumbnailURL = "img/cate/chua-phan-loai.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Chuẩn CMNR", Slug = "Chuẩn CMNR".Slugify(), Description = "Chuẩn luôn, chuẩn như lê duẩn, chuẩn không cần chỉnh, chỉnh là không còn chuẩn ...", ThumbnailURL = "img/cate/cmnr.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Chửi nghệ thuật", Slug = "Chửi nghệ thuật".Slugify(), Description = "Chửi theo bài bản, sách vở, văn hóa, văn minh.", ThumbnailURL = "img/cate/angry.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Con gái", Slug = "Con gái".Slugify(), Description = "Là con gái thật tuyệt", ThumbnailURL = "img/cate/girl.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Con trai - Con gái", Slug = "Con trai Con gái".Slugify(), Description = "Phụ nữ có thể làm tất cả ... nếu có đàn ông giúp đỡ", ThumbnailURL = "img/cate/male-female.png", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Cuộc sống", Slug = "Cuộc sống".Slugify(), Description = "Hãy sống, đừng tồn tại!", ThumbnailURL = "img/cate/life.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Dân IT", Slug = "Dân IT".Slugify(), Description = "Anh học CNTT hả, cài win dùm em nhé <3", ThumbnailURL = "img/cate/programmer.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Dê cụ", Slug = "Dê cụ".Slugify(), Description = "No caption =))", ThumbnailURL = "img/cate/de.jpg", IsPublished = true, IsFavorite = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Đàn ông", Slug = "Đàn ông".Slugify(), Description = "Người đàn ông vĩ đại bởi những hành động, không phải là do bẩm sinh.", ThumbnailURL = "img/cate/man.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Động lực", Slug = "Động lực".Slugify(), Description = "Cả những người giỏi hơn bạn cũng đang cố gắng thì tại sao bạn lại dám bỏ cuộc", ThumbnailURL = "img/cate/motivation.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "FA", Slug = "FA".Slugify(), Description = "Ép dầu.ép mỡ... chứ ai nỡ ép ây (FA)!", ThumbnailURL = "img/cate/fa.jpg", IsPublished = true, IsFavorite = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Giàu nghèo", Slug = "Giàu nghèo".Slugify(), Description = "Đối với tôi, việc anh giàu hay nghèo không quan trọng, miễn là… anh có tiền", ThumbnailURL = "img/cate/rich-poor.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Học hành", Slug = "Học hành".Slugify(), Description = "Nhất quỷ nhì ma thứ ba học trò", ThumbnailURL = "img/cate/study.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Hỏi ngu", Slug = "Hỏi ngu".Slugify(), Description = "Ngây ngô ngu ngơ ngờ nghệch ngốc nghếch", ThumbnailURL = "img/cate/dinosaur.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Hôn nhân", Slug = "Hôn nhân".Slugify(), Description = "Lấy vợ như có thêm một bà mẹ nhưng lại ko đc đối xử như một đứa con", ThumbnailURL = "img/cate/hon-nhan.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Làm quen với người lạ", Slug = "Làm quen với người lạ".Slugify(), Description = "Những câu nói làm quen, bắt chuyện với người lạ", ThumbnailURL = "img/cate/cupid.png", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Ngược", Slug = "Ngược".Slugify(), Description = "Chết cho người phụ nữ mình yêu thì dễ hơn là phải sống chung với họ.", ThumbnailURL = "img/cate/nguoc.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Nói lái", Slug = "Nói lái".Slugify(), Description = "Những câu nói lái bá đạo", ThumbnailURL = "img/cate/noi-lai.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Nụ cười", Slug = "Nụ cười".Slugify(), Description = "Khi cuộc đời cho bạn cả trăm lý do để khóc, hãy cho đời thấy bạn có cả ngàn lý do để cười.", ThumbnailURL = "img/cate/smile.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Quảng cáo", Slug = "Quảng cáo".Slugify(), Description = "Quảng cáo chế hài, slogan bá đạo, ...", ThumbnailURL = "img/cate/quang-cao.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Sống chất", Slug = "Sống chất".Slugify(), Description = "Cuộc sống luôn cho bạn cơ hội thứ hai. Đó là ngày mai", ThumbnailURL = "img/cate/lifeline.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Tâm trạng", Slug = "Tâm trạng".Slugify(), Description = "Khi cảm xúc lên ngôi", ThumbnailURL = "img/cate/sad.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Tán gái", Slug = "Tán gái".Slugify(), Description = "Bí kíp tán gái không khoái mới lạ", ThumbnailURL = "img/cate/tan-gai.jpg", IsPublished = true, IsFavorite = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Thầy cô", Slug = "Thầy cô".Slugify(), Description = "Những câu nói bất hủ của thầy cô", ThumbnailURL = "img/cate/teacher.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Thi cử", Slug = "Thi cử".Slugify(), Description = "Đề bài đều nằm gọn trong những phần...em chưa học!", ThumbnailURL = "img/cate/graduation_hat.png", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Tiền bạc", Slug = "Tiền bạc".Slugify(), Description = "Sống trên đời sống, cần có 1 đống tiền", ThumbnailURL = "img/cate/tien.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Tình yêu", Slug = "Tình yêu".Slugify(), Description = "Yêu là mất trong….nhà 1 đống !", ThumbnailURL = "img/cate/love.jpg", IsPublished = true, IsFavorite = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Trả lời bá đạo", Slug = "Trả lời bá đạo".Slugify(), Description = "Dành cho những lúc bối rối :v", ThumbnailURL = "img/cate/answer.jpg", IsPublished = true });
                context.Categories.Add(new Category { Id = Guid.NewGuid(), Name = "Troll", Slug = "Troll".Slugify(), Description = "Nothing is impossible !!!", ThumbnailURL = "img/cate/troll.jpg", IsPublished = true });

                await context.SaveChangesAsync();
            }
        }
    }
}
