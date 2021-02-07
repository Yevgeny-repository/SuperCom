export class UserModel {
    constructor(
        public id: string,
        public userName: string,
        public firstName: string,
        public lastName: string,
        public timeZone: string,
        public webSite: string,
        public phoneSkype: string,
        public imageData: string,
        public about: string,
      ) { }
}
